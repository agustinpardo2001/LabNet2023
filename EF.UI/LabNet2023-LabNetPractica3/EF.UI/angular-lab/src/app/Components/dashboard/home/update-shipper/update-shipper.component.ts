import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { ShipperServiceService } from 'src/app/Components/service/shippers.service.service';
import { ShipperModel } from 'src/app/core/Models/shippers_models';

@Component({
  selector: 'app-update-shipper',
  templateUrl: './update-shipper.component.html',
  styleUrls: ['./update-shipper.component.css']
})
export class ShipperUpdateComponent implements OnInit, OnDestroy {

  public id: string | null;
  public shipper!: ShipperModel;
  destroy: Subject<void> = new Subject();

 constructor(private route: ActivatedRoute, private shipperservice: ShipperServiceService, private router: Router) {
  this.id = this.route.snapshot.paramMap.get('id'); 
 }

  ngOnInit() {
    this.shipperservice.getShipperById(this.id ? this.id : "1").pipe(takeUntil(this.destroy)).subscribe(shipper => this.shipper = shipper)
  }

  ngOnDestroy(): void {
    this.destroy.next();
    this.destroy.complete();
  }
  
  onSubmit(data: any) : void {
    let updatedShipper : ShipperModel = new ShipperModel(this.id ? +this.id : 1, data.name, data.phone)

    this.shipperservice.updateShipper(updatedShipper).pipe(takeUntil(this.destroy)).subscribe(res => this.router.navigateByUrl('/home'))
  }
}