import { Component, OnInit, Input } from '@angular/core';
import { MatTableDataSource } from '@angular/material';
import { PeopleService } from '../services/people.service';
import { Person } from '../models/person';

@Component({
  selector: 'app-people-table',
  templateUrl: './people-table.component.html',
  styleUrls: ['./people-table.component.sass']
})
export class PeopleTableComponent implements OnInit {

  @Input() people: Person[];

  dataSource: MatTableDataSource<Person>;

  displayedColumns: string[] = ['FirstName','LastName','Address'];

  constructor(private peopleApi: PeopleService) { }

  ngOnInit() {
    this.peopleApi.getPeople().subscribe((results: Person[]) =>
      this.dataSource = new MatTableDataSource(results));

  }

}
