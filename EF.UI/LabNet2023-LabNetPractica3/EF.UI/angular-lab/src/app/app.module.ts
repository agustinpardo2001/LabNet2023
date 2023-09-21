import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './Components/login/login.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SharedModule } from './Components/shared/shared.module';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ShipperUpdateComponent} from './Components/dashboard/home/update-shipper/update-shipper.component';
import { ShipperAddComponent } from './Components/dashboard/home/add-shipper/add-shipper.component';
import { FormComponent } from './Components/form/form.component';
import { ShipperServiceService } from './Components/service/shippers.service.service';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    ShipperAddComponent,
    ShipperUpdateComponent,
    FormComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    SharedModule,
    HttpClientModule,
    
   
  ],
  providers: [ShipperServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
