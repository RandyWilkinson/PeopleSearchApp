import { Component, OnInit } from '@angular/core';
import { PeopleService } from '../services/people.service';
import { Person } from '../models/person';
import { Observable, Subject, of } from 'rxjs';
import {
  catchError,
  debounceTime,
  distinctUntilChanged,
  switchMap,
  tap
} from 'rxjs/operators';

@Component({
  selector: 'app-people-search',
  templateUrl: './people-search.component.html',
  styleUrls: ['./people-search.component.sass']
})
export class PeopleSearchComponent implements OnInit {

  peopleData: Observable<Person[]>;
  searchInFlight = false;
  goSlow = false;

  private searchTerms = new Subject<string>();

  constructor(private peopleApi: PeopleService) { }

  ngOnInit() {
    this.peopleData = this.searchTerms.pipe(
      debounceTime(300), // wait for 300ms pause in events
      distinctUntilChanged(), // ignore if next search term is same as previous
      tap(x => this.searchInFlight = true),
      switchMap(
        term =>
          term // switch to new observable each time
            ? // return the http search observable
            this.peopleApi.findPeople(term, this.goSlow)
            : // or the observable of empty heroes if no search term
            of<Person[]>(null)
      ),
      tap(x => this.searchInFlight = false),
      catchError(error => {
        // TODO: real error handling
        console.log(`Error in component ... ${error}`);
        return of<Person[]>([]);
      })
    );

  }

  search(criteria: string) {
    // Push a search term into the observable stream.
    this.searchTerms.next(criteria);
  }

}
