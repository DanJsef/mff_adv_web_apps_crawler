FROM docker.io/library/node:14.17.4-alpine3.14 as base
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
