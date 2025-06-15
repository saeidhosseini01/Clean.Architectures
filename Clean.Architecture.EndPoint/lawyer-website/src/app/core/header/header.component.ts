import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';

import { ConstService } from '../../services/common/const-services.service';
import { TValue } from '../../interface/TValue';
import { RegisterComponent } from '../../pages/register/register.component';
import { MatDialog } from '@angular/material/dialog';



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
   constructor(private constServices:ConstService,private dialog: MatDialog
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
  
  openRegisterDialog() {
      this.openPupUp();
    }
    openPupUp() {
      this.dialog.open(RegisterComponent, {
        width: '50%',
        enterAnimationDuration: '1000ms',
        exitAnimationDuration: '1000ms'
      });
  }

  // 🔹 اسکرول به بخش تماس با من
  scrollToContact(): void {
    const contactSection = document.getElementById('contact');
    if (contactSection) {
      contactSection.scrollIntoView({ behavior: 'smooth' });
    }
  }
}
