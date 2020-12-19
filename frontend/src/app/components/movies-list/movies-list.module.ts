import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { DxDataGridModule } from 'devextreme-angular';
import { MoviesListComponent } from './movies-list.component';
import { MoviesTableComponent } from './movies-table/movies-table.component';

@NgModule({
  imports: [
    // angular modules
    CommonModule,
    RouterModule,

    // devexpress modules
    DxDataGridModule,
  ],
  declarations: [MoviesListComponent, MoviesTableComponent],
  exports: [],
})
export class MoviesListModule {}
