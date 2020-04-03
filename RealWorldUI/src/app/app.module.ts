import { HttpClientModule } from '@angular/common/http';
import {HttpModule} from '@angular/http';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { CarFormComponent } from './components/car-form/car-form.component';
import { CarService } from './services/car.service';

@NgModule({
  declarations: [
    AppComponent,
    CarFormComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'car/new', component: CarFormComponent }
    ]),
    FormsModule,
    HttpModule

  ],
  providers: [
    CarService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
