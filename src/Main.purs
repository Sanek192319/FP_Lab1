module Main where

import Prelude
import Lab1 as Lab1
import Data.List (List(..))

import Effect (Effect)
import Effect.Console (log)

main :: Effect Unit
main = do
  log $ "\n"
  log $ "1.Singleton: "
  log $ show $ Lab1.singleton "qwerty"
  log $ show $ Lab1.singleton 1
  log $ "\n"
  log $ "2.null: "
  log $ show $ Lab1.null Nil
  log $ show $ Lab1.null (Cons 10(Cons 20 Nil))
  log $ show $ Lab1.null (Nil :: List Int)
  log $ "\n"
  log $ "3.snoc: "
  log $ show $ Lab1.snoc (Lab1.singleton 1) 3
  log $ show $ Lab1.snoc (Cons 10 (Cons 20 Nil)) 40
  log $ "\n"
  log $ "4.length: "
  log $ show $ Lab1.length (Cons 10(Cons 20(Cons 50 Nil)))
  log $ show $ Lab1.length (Lab1.snoc (Lab1.singleton 1) 3)

