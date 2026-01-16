section .data
	val1 db 5
	val2 db 4
	result db 0
	newline db 0xA
section .text
global _start

_start:
	mov al, [val1]
	add al, [val2]
	add al, '0'
	mov [result], al

	mov rax, 1
	mov rdi, 1
	mov rsi, result
	mov rdx, 1
	syscall

	mov rax, 1
	mov rdi, 1
	mov rsi, newline
	mov rdx, 1
	syscall

	mov rax, 60
	xor rdi, rdi
	syscall
