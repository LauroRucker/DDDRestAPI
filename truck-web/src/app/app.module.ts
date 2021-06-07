import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NewtruckComponent } from './newtruck/newtruck.component';
import { EdittruckComponent } from './edittruck/edittruck.component';
import { RemovetruckComponent } from './removetruck/removetruck.component';
import { GettrucksComponent } from './gettrucks/gettrucks.component';

@NgModule({
  declarations: [
    AppComponent,
    NewtruckComponent,
    EdittruckComponent,
    RemovetruckComponent,
    GettrucksComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
