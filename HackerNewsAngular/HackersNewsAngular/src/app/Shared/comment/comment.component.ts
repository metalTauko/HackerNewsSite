import { Component, OnInit, Input } from '@angular/core';
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

  constructor(private commentService:CommentService) { }

  ngOnInit() {
    this.getComment(this.commentId);
  }
  
  getComment(commentId){
    this.commentService.getItem(commentId).subscribe(
      data => {
        this.comment = data;
      }
    );
  }
}
