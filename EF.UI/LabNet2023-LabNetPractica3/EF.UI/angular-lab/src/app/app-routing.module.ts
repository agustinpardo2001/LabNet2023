import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';
import { HomeComponent } from './Components/dashboard/home/home.component';
import { ShipperAddComponent } from './Components/dashboard/home/add-shipper/add-shipper.component';
import { ShipperUpdateComponent } from './Components/dashboard/home/update-shipper/update-shipper.component';

const routes: Routes = [
  { path: "home", component: HomeComponent },
  { path: 'shipperAdd', component: ShipperAddComponent },
  { path: 'shipperUpdate/:id', component: ShipperUpdateComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }