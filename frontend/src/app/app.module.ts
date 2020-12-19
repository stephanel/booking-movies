import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MoviesListModule } from './components/movies-list/movies-list.module';
import { ServicesModule } from './services/services.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MovieDetailsModule } from './components/movie-details/movie-details.module';

@NgModule({
  declarations: [AppComponent],
  imports: [
    // angular modules
    BrowserAnimationsModule,
    BrowserModule,

    // app modules
    AppRoutingModule,
    MovieDetailsModule,
    MoviesListModule,
    ServicesModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
