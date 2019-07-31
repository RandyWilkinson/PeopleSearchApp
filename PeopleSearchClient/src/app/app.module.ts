import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { MatTableModule } from '@angular/material';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PeopleSearchComponent } from './people-search/people-search.component';
import { PeopleTableComponent } from './people-table/people-table.component';
import { PeopleService } from './services/people.service';

@NgModule({
  declarations: [
    AppComponent,
    PeopleSearchComponent,
    PeopleTableComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatTableModule
  ],
  providers: [
    PeopleService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
