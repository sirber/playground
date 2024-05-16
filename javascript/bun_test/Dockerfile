FROM oven/bun:alpine

WORKDIR /app

COPY package.json ./
COPY bun.lockb ./
RUN bun install --production

COPY src ./

ENTRYPOINT [ "bun", "run", "src/index.ts" ]