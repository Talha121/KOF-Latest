import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AllBrandsComponent } from './AllBrands/AllBrands.component';

const routes: Routes = [
  {
    path: '',
    component: AllBrandsComponent,
    data: {
      breadcrumb: 'Brands',
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
export class BrandRoutingModule { }
