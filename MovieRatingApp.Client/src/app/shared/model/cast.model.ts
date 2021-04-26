import { ActorDto } from './actor.model';
export interface CastDto {
  castId: number;
  role: string;
  actorId: number;
  actor: ActorDto;
  contentId: number;
}
