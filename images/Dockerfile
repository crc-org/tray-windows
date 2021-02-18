FROM registry.fedoraproject.org/fedora:latest
WORKDIR /app

RUN dnf install -y mono-devel nuget && \
    nuget update -self

COPY . .
