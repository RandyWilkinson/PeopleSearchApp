import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PeopleTableComponent } from './people-table.component';
import { MatTableModule } from '@angular/material';
import { CdkTableModule } from '@angular/cdk/table';
import { HttpClientModule } from '@angular/common/http';

describe('PeopleTableComponent', () => {
  let component: PeopleTableComponent;
  let fixture: ComponentFixture<PeopleTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [PeopleTableComponent],
      imports: [
        HttpClientModule,
        MatTableModule,
        CdkTableModule
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PeopleTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
