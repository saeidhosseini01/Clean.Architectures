import { Component } from '@angular/core';
import { MaterialModule } from '../../../material.module';

@Component({
  standalone: true,
  selector: 'app-icons',
  imports: [MaterialModule],
  templateUrl: './icons.component.html',
})
export class AppIconsComponent { }
