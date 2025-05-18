import { Routes } from '@angular/router';
import { HomeComponent } from './Commpnent/home/home.component';
import { AboutComponent } from './Commpnent/about/about.component';
import { AddUserComponent } from './Commponent/User/add-user/add-user.component';
import { EditeUserComponent } from './Commponent/User/edite-user/edite-user.component';
import { ShowUsersComponent } from './Commponent/User/show-users/show-users.component';





export const routes: Routes = [
{path:'',component:HomeComponent },
{path:'About',component:AboutComponent},
{path:'user',component:ShowUsersComponent},
{path:'user/:id',component:EditeUserComponent}

];
