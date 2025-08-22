package main

import (
	"encoding/json"
	"fmt"
	"log"
	"os"
	"net/http"
	"github.com/google/uuid"
)

type Response struct {
	Message string `json:"message"`
}

func handler(w http.ResponseWriter, r *http.Request) {
	id := uuid.New()
	resp := Response{ Message: fmt.Sprintf("%s - Welcome to Risk-Service!", id.String()) }
	w.Header().Set("Content-Type", "application/json")
	json.NewEncoder(w).Encode(resp)
}

func main() {
	port := os.Getenv("PORT")
    if port == "" {
        port = "8081" // default if not set
    }

	http.HandleFunc("/api", handler)
	log.Println(fmt.Sprintf("Risk-Service Server started on port %s", port))
	log.Fatal(http.ListenAndServe(":" + port, nil))
}

