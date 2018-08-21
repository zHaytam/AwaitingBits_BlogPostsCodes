from PIL import Image, ImageDraw


def create_image_with_ball(width, height, ball_x, ball_y, ball_size):
    """
    Creates an image and a ball inside it
    :param width: The width of the image.
    :param height: The height of the image.
    :param ball_x: The X position of the ball.
    :param ball_y: The Y position of the ball.
    :param ball_size: The size of the ball.
    :return: The created image.
    """

    img = Image.new('RGB', (width, height), (255, 255, 255))
    draw = ImageDraw.Draw(img)
    # draw.ellipse takes a 4-tuple (x0, y0, x1, y1) where (x0, y0) is the top-left bound of the box
    # and (x1, y1) is the lower-right bound of the box.
    draw.ellipse((ball_x, ball_y, ball_x + ball_size, ball_y + ball_size), fill='red')
    return img


if __name__ == '__main__':

    # Create the frames
    frames = []
    x, y = 0, 0
    for i in range(10):
        new_frame = create_image_with_ball(400, 400, x, y, 40)
        frames.append(new_frame)
        x += 40
        y += 40

    # Save into a GIF file that loops forever
    frames[0].save('moving_ball.gif', format='GIF', append_images=frames[1:], save_all=True, duration=100, loop=0)
