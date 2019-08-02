import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PeopleSearchComponent } from './people-search.component';
import { PeopleService } from '../services/people.service';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatFormFieldModule, MatSlideToggleModule, MatInputModule, MatProgressSpinnerModule, MatTableModule } from '@angular/material';
import { FormsModule } from '@angular/forms';
import { PeopleTableComponent } from '../people-table/people-table.component';
import { CdkTableModule } from '@angular/cdk/table';
import { HttpClientModule } from '@angular/common/http';

describe('PeopleSearchComponent', () => {
  let component: PeopleSearchComponent;
  let fixture: ComponentFixture<PeopleSearchComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        PeopleSearchComponent,
        PeopleTableComponent
      ],
      imports: [
        BrowserModule,
        BrowserAnimationsModule,
        HttpClientModule,
        MatFormFieldModule,
        MatTableModule,
        CdkTableModule,
        MatSlideToggleModule,
        MatInputModule,
        MatProgressSpinnerModule,
        FormsModule
      ],
      providers: [
        PeopleService
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PeopleSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
