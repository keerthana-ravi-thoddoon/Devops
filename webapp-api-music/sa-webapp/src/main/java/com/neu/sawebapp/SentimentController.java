package com.neu.sawebapp;

import com.neu.sawebapp.dto.SentenceDto;
import com.neu.sawebapp.dto.SentimentDto;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.client.RestTemplate;
 @CrossOrigin(origins = "*") 
 @RestController 
 public class SentimentController {
 @Value("${http://localhost:5000/analyse?sentence=i+am+so+happy!}") 
 private String saLogicApiUrl; 
 @PostMapping("/sentiment") 
 public SentimentDto sentimentAnalysis(@RequestBody SentenceDto sentenceDto) {
 RestTemplate restTemplate = new RestTemplate();
 return restTemplate.postForEntity(saLogicApiUrl + "/analyse/sentiment",
 sentenceDto, SentimentDto.class)
.getBody();
 }@GetMapping("/testHealth") 
 public String testHealth() {
 return "hello world!";
 }
}