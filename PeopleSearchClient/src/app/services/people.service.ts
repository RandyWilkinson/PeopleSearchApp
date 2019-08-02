import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpErrorResponse } from '@angular/common/http';
import { Person } from '../models/person';
import { catchError } from 'rxjs/operators';
import { Observable, throwError as observableThrowError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PeopleService {

  peopleUrl = 'https://localhost:44300/api/people';

  constructor(private http: HttpClient) { }

  getPeople(): Observable<Person[]> {
    return this.http.get<Person[]>(this.peopleUrl);
  }

  findPeople(term: string, delay: boolean): Observable<Person[]> {
    term = term.trim();

    // Add safe, URL encoded search parameter if there is a search term
    const options = term ?
      { params: new HttpParams().set('criteria', term) } : {};

    var url = delay ? `${this.peopleUrl}/slow` : this.peopleUrl;
    return this.http.get<Person[]>(url, options)
      .pipe(
        catchError(this.handleError)
      );
  }

  private handleError(res: HttpErrorResponse) {
    console.error(res.error);
    return observableThrowError(res.error || 'Server error');
  }
}
