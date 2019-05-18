import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { CommentService } from './comment.service';
import { Comment } from '../../Models/Models';


@Component({
  selector: 'app-comment',
  templateUrl: './comment.component.html',
  styleUrls: ['./comment.component.scss'],
  providers:[CommentService]
})
export class CommentComponent implements OnInit {


  @Input()
  commentId : number;

  comment:Comment;

  @Output()
  loadingInd = new EventEmitter<boolean>();


  constructor(private commentService:CommentService) { }

  ngOnInit() {
    this.getComment(this.commentId);
  }
  
  getComment(commentId){
    this.loadingInd.emit(true);
    this.commentService.getItem(commentId).subscribe(
      data => {
        this.comment = data;
        this.loadingInd.emit(false);
      }
    );
  }
}
