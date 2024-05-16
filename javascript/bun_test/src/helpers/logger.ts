import { getNow } from "./date";

export function log(message: string) {
  console.log(`[${getNow()}] ${message}`);
}

export function logAccess(message: string, ip: string | null = null) {
  console.log(`[${getNow()}][${ip ?? "unknown ip"}] ${message}`);
}
