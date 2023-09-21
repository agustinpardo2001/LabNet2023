import { Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';
import { ShipperModel } from 'src/app/core/Models/shippers_models';
import { ShipperServiceService } from '../../service/shippers.service.service';
import { Subject, takeUntil } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit, OnDestroy {
  shippers: ShipperModel[] = [];
  destroy: Subject<void> = new Subject();

  
  dataSource: any;

  constructor(private router: Router, private shipperservice: ShipperServiceService){
    
  

  }

  ngOnInit(): void {
    this.shipperservice.getShippers().pipe(takeUntil(this.destroy)).subscribe(shippers => this.shippers = shippers)
  }

  ngOnDestroy(): void {
      this.destroy.next();
      this.destroy.complete();
  }


  


  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

   
  }

addShippers(): void {
  this.router.navigateByUrl('/shipperAdd')
}


editShippers(id: number): void {
  this.router.navigateByUrl(`/shipperUpdate/${id}`);
}

deleteShippers(id: number): void {
  this.shipperservice.deleteShipper(id).pipe(takeUntil(this.destroy)).subscribe(res => 
    this.shipperservice.getShippers().pipe(takeUntil(this.destroy)).subscribe(shippers => this.shippers = shippers))
}


}
