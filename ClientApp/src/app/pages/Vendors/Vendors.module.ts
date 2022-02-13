import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VendorsComponent } from './Vendors.component';
import { VendorsRoutingModule } from './VendorRouting.routing';
import { AllVendorsComponent } from './AllVendors/AllVendors.component';
import { SharedModule } from '../../../../src/app/shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgxDropzoneModule } from 'ngx-dropzone';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgxPaginationModule } from 'ngx-pagination';
import { VendorDetailComponent } from './VendorDetail/VendorDetail.component';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';

@NgModule({
  imports: [
    CommonModule,
    VendorsRoutingModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxDropzoneModule,
    Ng2SearchPipeModule,
    NgxPaginationModule,
    NgxSpinnerModule,  
  ],
  declarations: [VendorsComponent,AllVendorsComponent,VendorDetailComponent],
  providers:[NgxSpinnerService]
})
export class VendorsModule { }
