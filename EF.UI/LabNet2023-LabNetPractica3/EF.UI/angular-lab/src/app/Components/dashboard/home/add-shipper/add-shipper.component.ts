import { Component, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { ShipperServiceService } from 'src/app/Components/service/shippers.service.service';
import { PostShipperModel } from 'src/app/core/Models/postShipperModel';

@Component({
  selector: 'app-add-shipper',
  templateUrl: './add-shipper.component.html',
  styleUrls: ['./add-shipper.component.css']
})
export class ShipperAddComponent implements OnDestroy{

  destroy: Subject<void> = new Subject();

  constructor(private shipperservice: ShipperServiceService, private router: Router) {}

  onSubmit(data: any) : void {
    let newShipper = new PostShipperModel(data.name, data.phone)
    this.shipperservice.postShipper(newShipper).pipe(takeUntil(this.destroy)).subscribe(resp =>  this.router.navigateByUrl('/home'));
    
  }

  ngOnDestroy(): void {
    this.destroy.next();
    this.destroy.complete();
  }

 
}