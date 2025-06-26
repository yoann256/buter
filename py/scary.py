import pygame
import random
import sys

# Initialize Pygame
pygame.init()

# Screen settings
WIDTH, HEIGHT = 800, 600
screen = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption("Matrix Rain")

# Font settings
FONT_SIZE = 20
font = pygame.font.SysFont("Consolas", FONT_SIZE, bold=True)

# Colors
GREEN = (0, 255, 0)
FADE_BLACK = (0, 0, 0, 20)  # RGBA for motion blur effect

# Prepare for motion blur using a surface
blur_surface = pygame.Surface((WIDTH, HEIGHT), pygame.SRCALPHA)

# Column setup
columns = WIDTH // FONT_SIZE
drops = [random.randint(-HEIGHT, 0) for _ in range(columns)]

# Clock
clock = pygame.time.Clock()

# Main loop
running = True
while running:
    # Handle events
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    # Apply motion blur
    blur_surface.fill(FADE_BLACK)
    screen.blit(blur_surface, (0, 0))

    # Draw falling characters
    for i in range(columns):
        char = random.choice(['0', '1'])
        text = font.render(char, True, GREEN)
        x = i * FONT_SIZE
        y = drops[i]

        screen.blit(text, (x, y))

        # Move drop down slowly
        drops[i] += FONT_SIZE // 2  # slower than full FONT_SIZE

        # Reset drop
        if drops[i] > HEIGHT:
            drops[i] = random.randint(-20 * FONT_SIZE, 0)

    pygame.display.flip()
    clock.tick(25)  # Lower FPS for smoother slower movement

pygame.quit()
sys.exit()
