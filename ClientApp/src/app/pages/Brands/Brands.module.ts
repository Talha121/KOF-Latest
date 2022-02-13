import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrandsComponent } from './Brands.component';
import { BrandRoutingModule } from './BrandRouting.routing';
import { AllBrandsComponent } from './AllBrands/AllBrands.component';
import { SharedModule } from '../../../../src/app/shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgxDropzoneModule } from 'ngx-dropzone';
import { Ng2OrderModule } from 'ng2-order-pipe';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgxPaginationModule } from 'ngx-pagination';
import { Brand } from '../../../../src/app/Models/Brand';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';

@NgModule({
  imports: [
    CommonModule,
    BrandRoutingModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxDropzoneModule,
    Ng2OrderModule,
    NgxSpinnerModule,
    Ng2SearchPipeModule,
    NgxPaginationModule
  ],
  declarations: [BrandsComponent,AllBrandsComponent],
  providers: [
    Brand,NgxSpinnerService
    ]
})
export class BrandsModule { }
