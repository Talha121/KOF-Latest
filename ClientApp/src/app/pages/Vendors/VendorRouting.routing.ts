import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AllVendorsComponent } from './AllVendors/AllVendors.component';
import { VendorDetailComponent } from './VendorDetail/VendorDetail.component';

const routes: Routes = [
  {
    path: '',
    component: AllVendorsComponent,
    data: {
      breadcrumb: 'Vendors',
      icon: 'icofont-table bg-c-blue',
      breadcrumb_caption: 'All Vendors',
      status: true
    }
  },
  {
    path: 'venderDetails/:vender_id',
    component: VendorDetailComponent,
    data: {
      breadcrumb: 'Vendors',
      icon: 'icofont-table bg-c-blue',
      breadcrumb_caption: 'All Vendors',
      status: true
    }
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class VendorsRoutingModule { }
