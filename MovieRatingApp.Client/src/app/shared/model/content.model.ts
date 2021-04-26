import { ContentTypeDTO } from './contentType.model';
import { ActorDto } from './actor.model';

export interface ContentDTO {
    contentId: number;
    title: string;
    description : string;
    releaseDate : Date;
    ratingPoints: number;
    contentTypeId : number;
    contentType : ContentTypeDTO;
    actorDto : ActorDto;
    photo : string;
}