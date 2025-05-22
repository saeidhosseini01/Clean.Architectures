import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { NgIf } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    ReactiveFormsModule,
    NgIf,
    MatCardModule
  ],
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  host: { class: 'custom-dialog-container' }
})
export class RegisterComponent  implements OnInit{
  Register: FormGroup;

  constructor(
    private fb: FormBuilder,
    private dialogRef: MatDialogRef<RegisterComponent> // ✅ فقط این کافیه
  ) {
    this.Register = this.fb.group({
      fname: ['', Validators.required],
      lname: ['', Validators.required],
      address: ['', Validators.required],
      phone: ['', [Validators.required, Validators.pattern(/^\d{10,15}$/)]],
      age: ['', [Validators.required, Validators.min(1), Validators.max(120)]],
    });
  }
  ngOnInit(): void {
  alert("sds");
  }

  onSubmit() {
    if (this.Register.valid) {
      this.dialogRef.close(this.Register.value); // ✅ بستن و ارسال دیتا
    } else {
      this.Register.markAllAsTouched(); // ✳️ نمایش ارورها
    }
  }

  onClose() {
    this.dialogRef.close(); 
  }
}
