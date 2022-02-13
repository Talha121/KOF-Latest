import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {DashboardDefaultComponent} from './dashboard-default.component';
import { StockinComponent } from './stockin/stockin.component';

const routes: Routes = [
  {
    path: '', 
    component: DashboardDefaultComponent,
    data: {
      breadcrumb: 'Dashboard',
      icon: 'icofont-home bg-c-blue',
      status: false
    },
  },
    {
      path: 'stockin',
      component: StockinComponent
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardDefaultRoutingModule { }
