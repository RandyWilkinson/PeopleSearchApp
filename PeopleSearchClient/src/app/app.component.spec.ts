import { TestBed, async } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { PeopleSearchComponent } from './people-search/people-search.component';
import { PeopleTableComponent } from './people-table/people-table.component';
import { MatToolbarModule, MatFormFieldModule, MatTableModule, MatSlideToggleModule, MatInputModule, MatProgressSpinnerModule } from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { CdkTableModule } from '@angular/cdk/table';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        AppComponent,
        PeopleSearchComponent,
        PeopleTableComponent
      ],
      imports: [
        BrowserModule,
        BrowserAnimationsModule,
        HttpClientModule,
        MatTableModule,
        MatToolbarModule,
        MatFormFieldModule,
        MatSlideToggleModule,
        MatInputModule,
        CdkTableModule,
        MatProgressSpinnerModule,
        FormsModule

      ]
    }).compileComponents();
  }));

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have as title 'PeopleSearchClient'`, () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.title).toEqual('PeopleSearchClient');
  });

  it('should render title in a material toolbar span', () => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('span').textContent).toContain('The People Search Application');
  });
});
