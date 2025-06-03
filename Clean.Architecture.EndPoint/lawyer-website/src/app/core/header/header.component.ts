import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HeaderItem } from '../../interface/header-item';
import { ConstService } from '../../services/common/const-services.service';


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
  headerTitles : HeaderItem[] =[];
    selectedid:number=0;
   constructor(private constServices:ConstService
  ) { 
  }
  ngOnInit(): void {
    this.LoadHeader();
  }
  LoadHeader():void {
    this.constServices.getHeader().subscribe({
      next:(data) => { console.log('✅ داده دریافتی:', data);this.headerTitles=data},
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
