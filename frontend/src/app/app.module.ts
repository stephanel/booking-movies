import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MoviesListModule } from './components/movies-list/movies-list.module';
import { ServicesModule } from './services/services.module';
@NgModule({
  declarations: [AppComponent],
  imports: [
    // angular modules
    BrowserModule,

    // app modules
    AppRoutingModule,
    MoviesListModule,
    ServicesModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
