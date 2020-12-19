import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { DxDataGridModule } from 'devextreme-angular';
import { MoviesListComponent } from './movies-list.component';
import { MoviesTableComponent } from './movies-table/movies-table.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { SearchMoviesComponent } from './search-movies/search-movies.component';

@NgModule({
  imports: [
    // angular modules
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,

    // material modules
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,

    // devexpress modules
    DxDataGridModule,
  ],
  declarations: [
    MoviesListComponent,
    MoviesTableComponent,
    SearchMoviesComponent,
  ],
  exports: [],
})
export class MoviesListModule {}
