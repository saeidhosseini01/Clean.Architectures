import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
    standalone: true,
    imports: [
    RouterModule,
  
     CommonModule
  ],
  styleUrls: ['./header.component.css'] // یا .scss اگر از scss استفاده می‌کنی
})
export class HeaderComponent  implements OnInit{
  hederTitls : string[] =['خانه', 'درباره ما', 'تماس با ما'];
    
   constructor(
  ) { }
  ngOnInit(): void {
    
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
