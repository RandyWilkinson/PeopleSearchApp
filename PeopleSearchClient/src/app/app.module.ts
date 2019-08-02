import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import {
  MatTableModule,
  MatToolbarModule,
  MatFormFieldModule,
  MatSlideToggleModule,
  MatInputModule,
  MatProgressSpinnerModule
} from '@angular/material';
import { CdkTableModule } from '@angular/cdk/table';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PeopleSearchComponent } from './people-search/people-search.component';
import { PeopleTableComponent } from './people-table/people-table.component';
import { PeopleService } from './services/people.service';
import { FormsModule } from '@angular/forms';

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
    MatTableModule,
    MatToolbarModule,
    MatFormFieldModule,
    MatSlideToggleModule,
    MatInputModule,
    CdkTableModule,
    MatProgressSpinnerModule,
    FormsModule

  ],
  providers: [
    PeopleService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
