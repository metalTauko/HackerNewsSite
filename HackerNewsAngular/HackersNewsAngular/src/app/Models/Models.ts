export interface BaseContent {

    by: string;
    rd: number;
    time: number;
    title: string;
    type: string;
}

export interface Comment extends BaseContent {
    kids: number[];

    parent: string;

    text: string;
}

export interface Story extends BaseContent {
    descendants: number;
    kids: number[];
    url: string;
    score: number;
}