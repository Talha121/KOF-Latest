import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoriesComponent } from './categories.component';
import { AllcategoriesComponent } from './Allcategories/Allcategories.component';
import { categoriesRoutingmodule } from './categoryrouting.routing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgxDropzoneModule } from 'ngx-dropzone';
import { SharedModule } from '../../../../src/app/shared/shared.module';
import { Ng2OrderModule } from 'ng2-order-pipe';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgxPaginationModule } from 'ngx-pagination';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';
import { Category } from '../../../../src/app/Models/Category';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    categoriesRoutingmodule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxDropzoneModule,
    Ng2OrderModule,
    NgxSpinnerModule,
    Ng2SearchPipeModule,
    NgxPaginationModule
  ],
  declarations: [CategoriesComponent,AllcategoriesComponent],
  providers: [
    NgxSpinnerService,Category
    ]
})
export class CategoriesModule { }
