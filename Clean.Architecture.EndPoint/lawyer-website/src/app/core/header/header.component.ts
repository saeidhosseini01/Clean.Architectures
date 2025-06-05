import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';

import { ConstService } from '../../services/common/const-services.service';
import { TValue } from '../../interface/TValue';



@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
    standalone: true,
    imports: [
    RouterModule,
 
     CommonModule
  ],
  styleUrls: ['./header.component.css'] 
})
export class HeaderComponent  implements OnInit{
  headerTitles : TValue<string>[] =[];
    selectedid:number=0;
   constructor(private constServices:ConstService
  ) { 
  }
  ngOnInit(): void {
    this.LoadHeader();
  }
  LoadHeader():void {
    this.constServices.getConstByKey('header').subscribe({
    next: (data) => {
  this.headerTitles = data;
},
      error :(err) => console.error('عملیات با خطا مواجه شد',err)
    })
  }
  
  openRegisterDialog(): void {
    // اینجا باید logic مربوط به باز کردن دیالوگ ثبت‌نام را قرار دهی
    // مثلاً با Material Dialog یا هر دیالوگ سفارشی
    console.log('دیالوگ ثبت‌نام باید باز شود');
  }

  // 🔹 اسکرول به بخش تماس با من
  scrollToContact(): void {
    const contactSection = document.getElementById('contact');
    if (contactSection) {
      contactSection.scrollIntoView({ behavior: 'smooth' });
    }
  }
}
