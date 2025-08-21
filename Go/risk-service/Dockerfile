# Stage 1: Start from the official Go image
FROM golang:1.25-alpine3.22 AS builder

# Set the working directory inside the container
WORKDIR /app

# Copy go.mod and go.sum first (better for caching)
COPY go.mod go.sum ./
RUN go mod download

# Copy the rest of the source code
COPY . .

# Build the Go binary
RUN go build -o risk-service .

# Stage 2: Final minimal image
FROM alpine:3.22

ARG PORT=8081

WORKDIR /app
COPY --from=builder /app/risk-service .

# Set port environment var
ENV PORT ${PORT}

# Expose this port from container
EXPOSE ${PORT}

# Command to run the binary
CMD ["./risk-service"]