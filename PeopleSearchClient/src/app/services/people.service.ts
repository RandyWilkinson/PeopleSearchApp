import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Person } from '../models/person';

@Injectable({
  providedIn: 'root'
})
export class PeopleService {
    [x: string]: any;

  constructor(private http: HttpClient) { }

  getPeople(): Observable<Person[]> {
    return this.http.get<Person[]>('https://localhost:44300/api/people')

  }
}
