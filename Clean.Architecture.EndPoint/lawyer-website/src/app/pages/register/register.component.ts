import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { NgIf } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { UserService } from '../../services/User/user.service';
import { IUserDto } from '../../interface/UserDto';

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
export class RegisterComponent implements OnInit {
  Register: FormGroup;

  constructor(
    private fb: FormBuilder,
    private userServices: UserService,
    private dialogRef: MatDialogRef<RegisterComponent> 
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

  }

  onSubmit() {
    if (this.Register.valid) {

      let _date: IUserDto = {
        id: this.Register.value.id as string,
        name: this.Register.value.name as string,
        family: this.Register.value.family as string,
        age: this.Register.value.age as number,
      }
      if (_date.id == null) {

        this.userServices.addUser(_date).subscribe({
          next: (value) => {
            (value);

          },
          error: (err) => console.error('عملیات با خطا مواجه شد', err)
        })


      } else {
        this.userServices.updateUser(_date).subscribe({
          next: (value) => {
            (value);

          },
          error: (err) => console.error('عملیات با خطا مواجه شد', err)

        })
      }
    } else {
      this.Register.markAllAsTouched(); // ✳️ نمایش ارورها
    }
  }

  onClose() {
    this.dialogRef.close();
  }
}
