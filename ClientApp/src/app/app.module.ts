import { BrowserModule } from '@angular/platform-browser';
import {NgModule, NO_ERRORS_SCHEMA} from '@angular/core';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { AdminComponent } from './layout/admin/admin.component';
import { BreadcrumbsComponent } from './layout/admin/breadcrumbs/breadcrumbs.component';
import { TitleComponent } from './layout/admin/title/title.component';
import { AuthComponent } from './layout/auth/auth.component';
import {SharedModule} from './shared/shared.module';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { AllInventoryComponent } from './pages/Products/AllInventory/AllInventory.component';
import { BasicLoginComponent } from './pages/auth/login/basic-login/basic-login.component';
import { MainPosComponent } from './pages/Pos/MainPos/MainPos.component';
import { DatePipe } from '@angular/common';
import { NgxPrintModule } from 'ngx-print';
import { InvoiceComponent } from './pages/Pos/Invoice/Invoice.component';

@NgModule({
  declarations: [
    AppComponent,
    AdminComponent,
    BreadcrumbsComponent,
    TitleComponent,
    AuthComponent,
    MainPosComponent,
    InvoiceComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    SharedModule,
    NgxPrintModule,
    HttpClientModule,
  ],
  schemas: [ NO_ERRORS_SCHEMA ],
  bootstrap: [AppComponent],
  providers: [DatePipe],
})
export class AppModule { }
