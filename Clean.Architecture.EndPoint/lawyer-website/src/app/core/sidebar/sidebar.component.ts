import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ConstService } from '../../services/common/const-services.service';
import { ConstItem } from '../../interface/const-item';



@Component({
  selector: 'app-sidebar',
    standalone: true,
    imports: [
    RouterModule,
  
     CommonModule
  ],
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})


export class SidebarComponent implements OnInit {

  constructor(private constServices:ConstService)  {
  

  }
sidebar:ConstItem[]=[];
selected:number=0;


  ngOnInit(): void {
   this.LoadsideBar();
  }

  LoadsideBar() {
  this.constServices.getConstByKey('sidebar').subscribe({
    next: (value) => {
      console.log('داده‌های دریافتی برای sidebar:', value);  // ✅ این خط لاگ رو اضافه کردیم
      this.sidebar = value;
    },
    error: (err) => console.error('عملیات با خطا مواجه شد:', err)
  });
}

}
