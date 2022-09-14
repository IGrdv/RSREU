import re
from decimal import *


def check_precedence(i):
    if i == '*' or "/":
        return 2
    elif i == '+' or '-':
        return 1


def to_postfix(expression):
    queue = []
    op_stack = []
    for i in expression:
        if i not in ('-', '+', '*', '/', '(', ')'):
            queue.append(i)
        elif i == "(":

            op_stack.append(i)
        elif i == ")":
            while op_stack:
                last = op_stack.pop()
                if last == "(":
                    break
                queue.append(last)
        else:
            while op_stack and check_precedence(i) <= check_precedence(op_stack[-1]) and op_stack[-1] != "(":
                queue.append(op_stack.pop())
            op_stack.append(i)
    while op_stack:
        queue.append(op_stack.pop())
    return queue


def calc(postfix):
    stack = []
    for value in postfix:
        if value in ['-', '+', '*', '/']:
            op1 = stack.pop()
            op2 = stack.pop()
            if value == '-':
                stack.append(op2 - op1)
            if value == '+':
                stack.append(op2 + op1)
            if value == '*':
                stack.append(op2 * op1)
            if value == '/':
                stack.append(op2 / op1)
        else:
            stack.append(Decimal(value))
    return stack.pop()


formula = input('> ')
tokenized_formula = re.findall(r"[\d.]+|[()+\-*/]", formula)
print(tokenized_formula)
postfix_expression = to_postfix(tokenized_formula)
print(postfix_expression)
print(calc(postfix_expression))
