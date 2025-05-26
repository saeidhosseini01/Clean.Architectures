import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
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
export class HeaderComponent {
  
  // 🔹 باز کردن دیالوگ ثبت‌نام
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
