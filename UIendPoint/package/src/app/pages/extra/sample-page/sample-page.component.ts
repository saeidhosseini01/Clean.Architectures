import { Component } from '@angular/core';
import { MaterialModule } from '../../../material.module';

@Component({
  standalone: true,
  selector: 'app-sample-page',
  imports: [MaterialModule],
  templateUrl: './sample-page.component.html',
})

export class AppSamplePageComponent { }
