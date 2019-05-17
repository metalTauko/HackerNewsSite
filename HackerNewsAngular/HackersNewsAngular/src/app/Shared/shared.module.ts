import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SearchBoxComponent } from './search-box/search-box.component';
import { CommentComponent } from './comment/comment.component';
import { TitleComponent } from './title/title.component';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    SearchBoxComponent,
    CommentComponent,
    TitleComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule
  ],
  exports:[
    SearchBoxComponent,
    CommentComponent,
    TitleComponent
  ],
  providers:[]
})
export class SharedModule { }
