import { TestBed } from '@angular/core/testing';

import { PeopleService } from './people.service';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { Person } from '../models/person';

describe('PeopleService', () => {
  let peopleService: PeopleService;
  let httpTestingController: HttpTestingController;

  const mockPeople = [
    { personId: '1', firstName: 'testFirst', lastName: 'testLast' },
    { personId: '2', firstName: 'testFirst1', lastName: 'testLast1' },
    { personId: '3', firstName: 'testFirst2', lastName: 'testLast2' }
  ] as Person[];

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [
        HttpClientTestingModule
      ],
      providers: [
        PeopleService
      ]
    });

    httpTestingController = TestBed.get(HttpTestingController);
    peopleService = TestBed.get(PeopleService);

  });

  afterEach(() => {
    httpTestingController.verify();
  });


  it('should be created', () => {
    expect(peopleService).toBeTruthy();
  });

  describe('findPeople', () => {
    it('should return mock people', () => {
      peopleService.findPeople('es', false).subscribe(
        people => expect(people.length).toEqual(this.mockPeople.length),
        fail
      );
      var mockPeopleLocal = [...mockPeople];
      // Receive GET request
      httpTestingController.match((request) => {
        return request.method === 'GET' &&
          request.url == peopleService.peopleUrl &&
          request.params.get('criteria') == 'es';    
      })[0].flush(mockPeopleLocal);

    });
  });

});
