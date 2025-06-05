import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ConstService } from '../../services/common/const-services.service';
import { TValue } from '../../interface/TValue';


@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [
    RouterModule,
    CommonModule
  ],
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})





export class FooterComponent implements OnInit {
  currentYear: number = new Date().getFullYear();
  footerTitle: TValue<string>[] = [];
  selectedid: number = 0;

  constructor(private constServices: ConstService) {
  }
  ngOnInit(): void {
    this.Loadfooter()

  }

  Loadfooter() {
    this.constServices.getConstByKey('footer').subscribe({
      next: (value) => { (value); this.footerTitle = value },
      error: (err) => console.error('عملیات با خطا مواجه شد', err)
    })

  }
}
