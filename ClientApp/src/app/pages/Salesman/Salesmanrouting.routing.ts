import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddSalesmanComponent } from './AddSalesman/AddSalesman.component';

const routes: Routes = [
  {
    path: '',
    component: AddSalesmanComponent,
    data: {
      breadcrumb: 'Salesman',
      icon: 'icofont-table bg-c-blue',
      breadcrumb_caption: 'All Brands Detail',
      status: true
    }
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SalesmanRoutingModule { }
