import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EdittruckComponent } from './edittruck/edittruck.component';
import { GettrucksComponent } from './gettrucks/gettrucks.component';
import { RemovetruckComponent } from './removetruck/removetruck.component';
import { NewtruckComponent } from './newtruck/newtruck.component';

const routes: Routes = [
  { path: 'edittruck', component: EdittruckComponent },
  { path: 'gettruck', component: GettrucksComponent },
  { path: 'removetruck', component: RemovetruckComponent },
  { path: 'newtruck', component: NewtruckComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
