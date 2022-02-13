import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InvoiceComponent } from './Invoice/Invoice.component';
import { MainPosComponent } from './MainPos/MainPos.component';


const routes: Routes = [
  {
    path: '',
    component: MainPosComponent,
    data: {
      breadcrumb: 'Pos',
      icon: 'icofont-table bg-c-blue',
      breadcrumb_caption: 'All Brands Detail',
      status: true
    }
  },
  {
    path: 'invoice',
    component: InvoiceComponent,
    data: {
      breadcrumb: 'Pos',
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
export class PosRoutingModule { }
