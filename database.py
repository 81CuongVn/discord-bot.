from peewee import *

from bot_config import bot_admin_id

db = SqliteDatabase('bot.db')


class BaseModel(Model):
    class Meta:
        database = db


class Moderator(BaseModel):
    discord_id = IntegerField(unique=True)
    sudoer = BooleanField(default=False)


class PiracyString(BaseModel):
    string = CharField(unique=True)


class FaqItem(BaseModel):
    key = CharField(unique=True)
    text = TextField(null=False)


def init():
    with db:
        db.get_tables()
        db.create_tables([Moderator, PiracyString, FaqItem])
        try:
            Moderator.get(discord_id=bot_admin_id)
        except DoesNotExist:
            Moderator(discord_id=bot_admin_id, sudoer=True).save()
